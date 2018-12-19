package inputs.web;

import org.openqa.selenium.By;
import org.openqa.selenium.WebElement;

import excel.Config;
import excel.PList;
import inputs.Input;
import testobjects.TestObject;
import testobjects.WebTest;


/** Rozwija wielopoziomowy picker (okno wyboru) wskazane przez Xpath, wybiera z niego opcjê Name i wraca do g³ównego okna. Wymaga Xpath i Name. 
 * Argument powinien byæ w postaci Level 1\Level 2\Level 3\...
 * */
public class PickerLevel2Input extends WebInput {
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
		String path = data;
		int index = path.indexOf('\\');
		
		while (index > (-1)) {
			String single = path.substring(0, index);
			WebElement row = driver.findElement(By.xpath("//td[text()[contains(.,'" + single + "')]]/parent::tr/td[1]/a"));
			row.click();
			path = path.substring(index+1);
			index = path.indexOf('\\');
		}

		driver.findElement(By.xpath("//input[contains(@value, '" + path + "')]")).click();
		driver.findElement(By.xpath("//span[contains(text(),'OK')]")).click();
		driver.switchTo().window(parent.parentWindow);
	}
	
	public PickerLevel2Input(Config config, WebTest parent) {
		super(config, parent);
	}
}
