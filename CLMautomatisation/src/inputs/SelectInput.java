package inputs;

import org.openqa.selenium.By;
import org.openqa.selenium.support.ui.Select;

import excel.Config;
import excel.PList;
import testobjects.TestObject;

/** Wybiera z rozwijanego menu (select) wartoœæ opisan¹ przez Name. Wymaga Xpath i Name. */
public class SelectInput extends Input {
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
		
		Select select = new Select(driver.findElement(By.xpath(xpath)));
		select.selectByVisibleText(data);
	}
	
	public SelectInput(Config config, TestObject parent) {
		super(config, parent);
	}
}
