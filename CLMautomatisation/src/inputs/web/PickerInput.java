package inputs.web;

import org.openqa.selenium.By;
import excel.Config;
import excel.PList;
import inputs.Input;
import testobjects.TestObject;
import testobjects.WebTest;

/** Rozwija picker (okno wyboru) wskazane przez Xpath, wybiera z niego opcjê Name i wraca do g³ównego okna. Wymaga Xpath i Name. */
public class PickerInput extends WebInput {
	
	@Override
	public void fill(PList testdata) throws Exception {
		super.fill(testdata);
		
		String data;
		if (name.charAt(0)=='&') {
			data = TestObject.globaldata.get(name.substring(1));
		}
		else if (name.charAt(0)=='$') {
			data = name.substring(1);
		}
		else {
			data = testdata.get(name);
		}
		
		driver.findElement(By.xpath(xpath)).click();
		parent.switchToNewWindow();
		driver.findElement(By.xpath("//input[contains(@value, '" + data + "')]")).click();
		driver.findElement(By.xpath("//span[contains(text(),'OK')]")).click();
		driver.switchTo().window(parent.parentWindow);
	}
	
	public PickerInput(Config config, WebTest parent) {
		super(config, parent);
	}
}
