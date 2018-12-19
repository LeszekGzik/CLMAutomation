package inputs.web;

import org.openqa.selenium.By;
import org.openqa.selenium.interactions.Actions;
import excel.Config;
import excel.PList;
import inputs.Input;
import testobjects.TestObject;
import testobjects.WebTest;

/** Przesuwa kursor nad wybrany element. Wymaga tylko Xpath. */
public class MoveToInput extends WebInput {
	
	@Override
	public void fill(PList testdata) throws Exception {
		super.fill(testdata);
		Actions action = new Actions(driver);
		action
			.moveToElement(driver.findElement(By.xpath(xpath)))
			.perform();
		Thread.sleep(1000);
	}
	
	public MoveToInput(Config config, WebTest parent) {
		super(config, parent);
	}
}
