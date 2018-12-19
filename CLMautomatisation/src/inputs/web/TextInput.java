package inputs.web;

import org.openqa.selenium.By;
import excel.Config;
import excel.PList;
import testobjects.TestObject;
import testobjects.WebTest;

/** Wpisuje do okna tekstowego zadany tekst. Wymaga Xpath i Name. */
public class TextInput extends WebInput {

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
		
		driver.findElement(By.xpath(xpath)).clear();
		driver.findElement(By.xpath(xpath)).sendKeys(data);
	}
	
	public TextInput(Config config, WebTest parent) {
		super(config, parent);
	}
}
