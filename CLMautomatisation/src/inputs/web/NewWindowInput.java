package inputs.web;

import excel.Config;
import excel.PList;
import inputs.Input;
import testobjects.TestObject;
import testobjects.WebTest;

/** Prze³¹cza siê na nowo otwarte okno. ¯adnych parametrów. Po ka¿dym NewWindow powinno siê powróciæ BackToWindow. */
public class NewWindowInput extends WebInput {
	
	@Override
	public void fill(PList testdata) throws InterruptedException {
		parent.switchToNewWindow();
	}
	
	public NewWindowInput(Config config, WebTest parent) {
		super(config, parent);
	}
}
