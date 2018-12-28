package testobjects;

import java.util.*;
import java.util.concurrent.TimeUnit;

import org.openqa.selenium.Proxy;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.firefox.FirefoxDriver;
import org.openqa.selenium.remote.CapabilityType;
import org.openqa.selenium.remote.DesiredCapabilities;
import org.openqa.selenium.support.ui.WebDriverWait;

import excel.Config;
import excel.PList;
import inputs.Input;
import inputs.web.*;
import logging.ReportManager;


/** Klasa realizuj¹ca pojedynczy test webowy. Zawiera tylko komendy typu WebInput. */
public class WebTest extends TestObject {

	public WebDriver driver;
	public String parentWindow;
	public WebDriverWait wait;
	
	/** Prze³¹cza siê na nowe okno (i.e. pierwsze nie oryginalne) */
	public void switchToNewWindow() {
		Set<String> windows = driver.getWindowHandles();
		for (String handle : windows) {
			if (!handle.equals(parentWindow)) {
				driver.switchTo().window(handle);
			}
		}
	}
	
	public WebTest(String name, String parentName, List<Config> config, PList testdata, Properties properties) {
		super(name,parentName, config, testdata, properties);
		String px = properties.getProperty("proxy");
		String url = properties.getProperty("proxyURL");
		DesiredCapabilities cap = new DesiredCapabilities(); 
		org.openqa.selenium.Proxy proxy = new Proxy();
		
		//ustawienie proxy
		if (px.equals("true")) {	
			proxy.setProxyType(Proxy.ProxyType.MANUAL);
			proxy.setHttpProxy(url);
			proxy.setSslProxy(url);
			cap.setCapability(CapabilityType.ACCEPT_SSL_CERTS, true);
			cap.setCapability(CapabilityType.PROXY, proxy);
		} else {
			proxy.setProxyType(Proxy.ProxyType.DIRECT);
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
				case "CMP":
					input = new CompareTextInput(c, this);
					inputs.add(input);
					break;
			}
		}
		getSteps();
		report = new ReportManager(driver, properties);
	}
	

	/** Zamyka okno przegl¹darki po zakoñczeniu testu */
	public void close() {
		if(driver!=null) {
			driver.quit();
		}
	}
}
