package inputs;

import excel.Config;
import excel.PList;
import testobjects.TestObject;

/** Zatwierdz alert(popup). ¯adnych parametrów. */
public class AlertInput extends Input {
	@Override
	public void fill(PList testdata) throws InterruptedException {
		driver.switchTo().alert().accept();
		driver.switchTo().window(parent.parentWindow);
		Thread.sleep(1000);
	}
	
	public AlertInput(Config config, TestObject parent) {
		super(config, parent);
	}
}
