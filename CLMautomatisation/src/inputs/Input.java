package inputs;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.support.ui.ExpectedCondition;
import org.openqa.selenium.support.ui.ExpectedConditions;

import excel.*;
import testobjects.*;

/** G��wna klasa przechowuj�ca informacj� o pojedynczej instrukcji (np. Button, GoTo itp.) */
public abstract class Input {
	public String name;
	public String xpath;
	public String type;
	public String step;
	public WebDriver driver;
	public TestObject parent;
	static int waitForInput;
	
	public static void setInputWait(int miliseconds) {
		waitForInput = miliseconds;
	}
	
	/** Zmienna okre�laj�ca czy nale�y kontynuowa� wykonywanie kroku */
	public boolean continueStep;
	
	/** Blok testuj�cy widoczno��, klikowalno�� i obecno�� elementu. Wywo�ywa� tylko dla Input�w posiadaj�cych Xpath =/= null */
	public void fill(PList testdata) throws Exception {
		Thread.sleep(waitForInput);
		parent.wait.until(ExpectedConditions.visibilityOfElementLocated(By.xpath(xpath)));
		parent.wait.until(ExpectedConditions.elementToBeClickable(By.xpath(xpath)));
		parent.wait.until(ExpectedConditions.presenceOfElementLocated(By.xpath(xpath)));
		parent.wait.until(new ExpectedCondition<Boolean>() {

            @Override
            public Boolean apply(WebDriver driver) {
                for (WebElement element : driver.findElements(By.xpath(xpath))) {
                    if (element.isDisplayed()) {
                        return true;
                    }
                }
                return false;
            }

        });
		Thread.sleep(waitForInput);
	}
	
	public Input(Config config, TestObject parent) {
		this.parent = parent;
		this.driver = parent.driver;
		this.name = config.getName();
		this.type = config.getType();
		this.xpath = config.getXpath();
		this.step = config.getStep();
		this.continueStep = true;
	}
}
