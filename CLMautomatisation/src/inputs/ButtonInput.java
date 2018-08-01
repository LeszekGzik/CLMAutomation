package inputs;

import org.openqa.selenium.By;

import excel.Config;
import excel.PList;
import testobjects.TestObject;

/** Klika w przycisk, link lub inny element. Wymaga tylko Xpath. */
public class ButtonInput extends Input {
	@Override
	public void fill(PList testdata) throws Exception {
		super.fill(testdata);
		driver.findElement(By.xpath(xpath)).click();
	}
	
	public ButtonInput(Config config, TestObject parent) {
		super(config, parent);
	}
}
