package inputs;

import excel.Config;
import excel.PList;
import testobjects.TestObject;

/** Wraca do g³ównego okna. ¯adnych parametrów. */
public class BackToWindowInput extends Input {
	@Override
	public void fill(PList testdata) throws InterruptedException {
		//driver.close();
		parent.driver.switchTo().window(parent.parentWindow);
	}
	
	public BackToWindowInput(Config config, TestObject parent) {
		super(config, parent);
	}
}
