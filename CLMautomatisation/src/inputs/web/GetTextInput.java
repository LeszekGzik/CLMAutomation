package inputs.web;

import org.openqa.selenium.By;

import excel.Config;
import excel.PList;
import inputs.Input;
import testobjects.TestObject;
import testobjects.WebTest;

/** Pobiera tekst z elementu i zapisuje go pod parametr o nazwie NAME. Wymaga Xpath i Name. */
public class GetTextInput extends WebInput {
	@Override
	public void fill(PList testdata) throws Exception {
		super.fill(testdata);
		PList data;
		if (name.charAt(0)=='&') {
			data = TestObject.globaldata;
			name = name.substring(1);
		}
		else {
			data = testdata;
		}
		
		if(data.get(name)!=null) {
			data.set(name, driver.findElement(By.xpath(xpath)).getText());
		}
		else {
			data.add(name, driver.findElement(By.xpath(xpath)).getText());
		}
	}
	
	public GetTextInput(Config config, WebTest parent) {
		super(config, parent);
	}
}
