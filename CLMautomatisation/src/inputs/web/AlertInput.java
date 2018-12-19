package inputs.web;

import excel.Config;
import excel.PList;
import inputs.Input;
import testobjects.TestObject;
import testobjects.WebTest;

/** Zatwierdz alert(popup). ¯adnych parametrów. */
public class AlertInput extends WebInput {
	@Override
	public void fill(PList testdata) throws InterruptedException {
		driver.switchTo().alert().accept();
		driver.switchTo().window(parent.parentWindow);
		Thread.sleep(1000);
	}
	
	public AlertInput(Config config, WebTest parent) {
		super(config, parent);
	}
}
