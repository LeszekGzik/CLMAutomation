package testobjects;

import java.io.IOException;
import java.util.ArrayList;
import java.util.LinkedHashSet;
import java.util.List;
import java.util.Properties;
import java.util.Set;
import java.util.concurrent.TimeUnit;

import org.openqa.selenium.Proxy;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.firefox.FirefoxDriver;
import org.openqa.selenium.remote.CapabilityType;
import org.openqa.selenium.remote.DesiredCapabilities;
import org.openqa.selenium.support.ui.WebDriverWait;

import excel.Config;
import excel.PList;
import exceptions.TestFailedException;
import exceptions.UntestedException;
import inputs.*;
import logging.ReportManager;

public class TestObject {
	public WebDriver driver;
	public String parentWindow;
	public WebDriverWait wait;
	public List<Input> inputs;
	public PList testdata;
	public Set<String> steps;
	public static ReportManager report;
	public static PList globaldata;
	public String name;
	String parentName;
	public Boolean continueTest;
	int maxRepetitions;
	
	/** Prze³¹cza siê na nowe okno (i.e. pierwsze nie oryginalne) */
	public void switchToNewWindow() {
		Set<String> windows = driver.getWindowHandles();
		for (String handle : windows) {
			if (!handle.equals(parentWindow)) {
				driver.switchTo().window(handle);
			}
		}
	}
	
	/** Wykonuje wszystkie polecenia w kroku STEP
	 * @return true jeœli krok wykona³ siê w ca³oœci 
	 * @throws Exception */
	public boolean performStep(String step) throws TestFailedException, IOException {
		TestFailedException temp = null;
		for (Input input : inputs) {
			try {
				if (input.step.equals(step)) {
					if (continueTest) {
						//Jeœli maxrepetitions > 1 ORAZ input siê nie wype³ni³, próbuj ponownie
						for(int i=0; i<maxRepetitions; i++) {	
							try {
								input.fill(testdata);
								break;
							} catch(Exception exception) {
								System.out.println("ERROR #"+(i+1));
								if (i==(maxRepetitions-1)) {
									throw exception;
								}
							}
						}
						if (!input.continueStep) {
							return false;
						}
						report.debug(parentName, name, step, input.type + " (" + input.xpath + ", " + input.name + ")", "OK", ReportManager.currentDateTime());
					}
					else {
						report.debug(parentName, name, step, input.type + " (" + input.xpath + ", " + input.name + ")", "UNTESTED", ReportManager.currentDateTime());
					}
				}
			} catch(Exception exception) {
				report.debug(parentName, name, step, input.type + " (" + input.xpath + ", " + input.name + ")", "FAILED", ReportManager.currentDateTime());
				temp = new TestFailedException(exception, name, step, input.type);
				continueTest = false;
			}
		}
		if (temp!=null) { throw temp; }
		return true;
	}

	/** Wykonuje wszystkie kroki, w kolejnoœci w jakiej by³y podane */
	public void performAllSteps() throws TestFailedException, UntestedException, IOException {
		TestFailedException temp = null;
		for (String step : steps) {
			try {
				if (continueTest) {
					boolean stepComplete = performStep(step);
					if (stepComplete) {
						report.step(parentName, name, step, "OK", ReportManager.currentDateTime());
					}
					else {
						report.step(parentName, name, step, "SKIPPED", ReportManager.currentDateTime());
					}
				}
				else {
					report.step(parentName, name, step, "UNTESTED", ReportManager.currentDateTime());
				}
			} catch (TestFailedException tfe) {
				report.step(parentName, name, step, "FAILED", ReportManager.currentDateTime());
				temp = tfe;
			}
		}
		if (temp!=null) { throw temp; }
		else if (!continueTest) { throw new UntestedException("UntestedException: Test has been stopped due to IFT or similiar command."); }
	}
	
	public TestObject(String name, String parentName, List<Config> config, PList testdata, Properties properties) {
		this.name = name;
		this.parentName = parentName;
		continueTest = true;
		maxRepetitions = Integer.parseInt(properties.getProperty("maxrepetitions"));
		String px = properties.getProperty("proxy");
		DesiredCapabilities cap = new DesiredCapabilities(); 
		org.openqa.selenium.Proxy proxy = new Proxy();
		
		//ustawienie proxy
		if (px.equals("")) {		 
			proxy.setProxyType(Proxy.ProxyType.DIRECT);
			cap.setCapability(CapabilityType.ACCEPT_SSL_CERTS, true);
			cap.setCapability(CapabilityType.PROXY, proxy);
		} else {
			proxy.setProxyType(Proxy.ProxyType.MANUAL);
			proxy.setHttpProxy(px);
			proxy.setSslProxy(px);
			cap.setCapability(CapabilityType.ACCEPT_SSL_CERTS, true);
			cap.setCapability(CapabilityType.PROXY, proxy);
		}
		
		System.setProperty("webdriver.gecko.driver",properties.getProperty("geckodriver"));
		System.setProperty("webdriver.firefox.bin", properties.getProperty("firefox"));
		driver = new FirefoxDriver(cap);
	    driver.manage().window().maximize();
	    driver.manage().timeouts().implicitlyWait(15, TimeUnit.SECONDS); 	//czekaj co najmniej 15 sekund przed wyrzuceniem wyj¹tku
	    parentWindow = driver.getWindowHandle();		//zapis uchwytu g³ównego okna do przysz³ego u¿ytku
	    wait = new WebDriverWait(driver, 15);
	    
		this.testdata = testdata;
		inputs = new ArrayList<Input>();
		steps = new LinkedHashSet<String>();
		
		for (Config c : config) {
			Input input;
			switch(c.getType()) {
				case "T":
					input = new TextInput(c, this);
					inputs.add(input);
					break;
				case "P":
					input = new PickerInput(c, this);
					inputs.add(input);
					break;
				case "PL2":
					input = new PickerLevel2Input(c, this);
					inputs.add(input);
					break;
				case "R":
					input = new RadioInput(c, this);
					inputs.add(input);
					break;
				case "S":
					input = new SelectInput(c, this);
					inputs.add(input);
					break;
				case "M":
					input = new MoveToInput(c, this);
					inputs.add(input);
					break;
				case "B":
					input = new ButtonInput(c, this);
					inputs.add(input);
					break;
				case "G":
					input = new GoToInput(c, this);
					inputs.add(input);
					break;
				case "A":
					input = new AlertInput(c, this);
					inputs.add(input);
					break;
				case "NW":
					input = new NewWindowInput(c, this);
					inputs.add(input);
					break;
				case "BTW":
					input = new BackToWindowInput(c, this);
					inputs.add(input);
					break;
				case "GET":
					input = new GetTextInput(c, this);
					inputs.add(input);
					break;
				case "W":
					input = new WaitInput(c, this);
					inputs.add(input);
					break;
				case "IF":
					input = new ConditionalInput(c, this);
					inputs.add(input);
					break;
				case "SCR":
					input = new ScreenshotInput(c, this);
					inputs.add(input);
					break;
				case "IFT":
					input = new ConditionalTestInput(c, this);
					inputs.add(input);
					break;
				case "EE" :
					input = new ElementExistsInput(c, this);
					inputs.add(input);
					break;
				case "ENE" :
					input = new ElementNotExistsInput(c, this);
					inputs.add(input);
					break;
				case "U" :
					input = new UploadFileInput(c, this);
					inputs.add(input);
					break;
				case "DAT":
					input = new CurrentDateInput(c, this);
					inputs.add(input);
					break;
			}
		}
		getSteps();
		report = new ReportManager(driver, properties);
	}
	
	/** Tworzy listê kroków do wykonania (unikatowych wartoœci Step w pliku config). */
	public void getSteps() {
		for (Input i : inputs) {
			steps.add(i.step);
		}
	}

	/** Inicjalizuje listê globalnych parametrów (globaldata) */
	public static void globalInit() {
		globaldata = new PList();
	}

	/** Zamyka okno przegl¹darki po zakoñczeniu testu */
	public void close() {
		if(driver.getWindowHandles()!=null)	{
			driver.quit();
		}
	}

}
