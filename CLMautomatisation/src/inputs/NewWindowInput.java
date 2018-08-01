package inputs;

import excel.Config;
import excel.PList;
import testobjects.TestObject;

/** Prze³¹cza siê na nowo otwarte okno. ¯adnych parametrów. Po ka¿dym NewWindow powinno siê powróciæ BackToWindow. */
public class NewWindowInput extends Input {
	
	@Override
	public void fill(PList testdata) throws InterruptedException {
		parent.switchToNewWindow();
	}
	
	public NewWindowInput(Config config, TestObject parent) {
		super(config, parent);
	}
}
