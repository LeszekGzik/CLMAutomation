package inputs;

import org.openqa.selenium.By;

import excel.Config;
import excel.PList;
import testobjects.TestObject;

/** Pobiera tekst z elementu i zapisuje go pod parametr o nazwie NAME. Wymaga Xpath i Name. */
public class GetTextInput extends Input {
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
	
	public GetTextInput(Config config, TestObject parent) {
		super(config, parent);
	}
}
