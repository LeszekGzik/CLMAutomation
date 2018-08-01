package inputs;

import excel.Config;
import excel.PList;
import testobjects.TestObject;

/** Prze��cza si� na nowo otwarte okno. �adnych parametr�w. Po ka�dym NewWindow powinno si� powr�ci� BackToWindow. */
public class NewWindowInput extends Input {
	
	@Override
	public void fill(PList testdata) throws InterruptedException {
		parent.switchToNewWindow();
	}
	
	public NewWindowInput(Config config, TestObject parent) {
		super(config, parent);
	}
}
