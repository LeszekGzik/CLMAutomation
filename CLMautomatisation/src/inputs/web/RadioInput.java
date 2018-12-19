package inputs.web;

import org.openqa.selenium.By;
import excel.Config;
import excel.PList;
import inputs.Input;
import testobjects.TestObject;
import testobjects.WebTest;

/** Zaznacza RadioButton o odpowiedniej wartoœci (value). Wymaga tylko Name. */
public class RadioInput extends WebInput {
	@Override
	public void fill(PList testdata) throws InterruptedException {
		
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
		driver.findElement(By.xpath("//input[contains(@class,'radio')][contains(@value, '" + data + "')]")).click();
	}
	
	public RadioInput(Config config, WebTest parent) {
		super(config, parent);
	}
}
