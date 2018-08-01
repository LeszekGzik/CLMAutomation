package inputs;

import excel.Config;
import excel.PList;
import testobjects.TestObject;

/** Wraca do g��wnego okna. �adnych parametr�w. */
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
