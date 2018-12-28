package inputs.sap;

import com.jacob.activeX.ActiveXComponent;

import excel.Config;
import excel.PList;
import inputs.Input;
import testobjects.*;

/** Klasa przechowuj¹ca informacje na temat pojedynczej instrukcji w testach webowych. */
public abstract class SAPInput extends Input {
	public SAPTest parent;
	public ActiveXComponent object, Session;

	public SAPInput(Config config, SAPTest parent) {
		super(config);
		this.parent = parent;
		Session = parent.Session;
	}

	public void fill(PList testdata) throws Exception {
		Thread.sleep(Input.waitForInput);
	}
}
