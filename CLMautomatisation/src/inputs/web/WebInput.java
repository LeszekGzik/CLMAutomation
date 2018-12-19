package inputs.web;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.support.ui.ExpectedCondition;
import org.openqa.selenium.support.ui.ExpectedConditions;

import excel.Config;
import excel.PList;
import inputs.Input;

import testobjects.*;

public abstract class WebInput extends Input {
	public WebDriver driver;
	public WebTest parent;
	
	public WebInput(Config config, WebTest parent) {
		super(config);
		this.parent = parent;
		this.driver = parent.driver;
	}

	public void fill(PList testdata) throws Exception {
		Thread.sleep(Input.waitForInput);
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
	}
}
