package inputs.web;

import org.openqa.selenium.By;

import excel.Config;
import excel.PList;
import inputs.Input;
import testobjects.TestObject;
import testobjects.WebTest;

/** Klika w przycisk, link lub inny element. Wymaga tylko Xpath. */
public class ButtonInput extends WebInput {
	@Override
	public void fill(PList testdata) throws Exception {
		super.fill(testdata);
		driver.findElement(By.xpath(xpath)).click();
	}
	
	public ButtonInput(Config config, WebTest parent) {
		super(config, parent);
	}
}
