package inputs.web;

import excel.Config;
import excel.PList;
import inputs.Input;
import testobjects.TestObject;
import testobjects.WebTest;

/** Wraca do g³ównego okna. ¯adnych parametrów. */
public class BackToWindowInput extends WebInput {
	@Override
	public void fill(PList testdata) throws InterruptedException {
		//driver.close();
		parent.driver.switchTo().window(parent.parentWindow);
	}
	
	public BackToWindowInput(Config config, WebTest parent) {
		super(config, parent);
	}
}
