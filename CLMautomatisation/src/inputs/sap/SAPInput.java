package inputs.sap;

import com.jacob.activeX.ActiveXComponent;

import excel.Config;
import excel.PList;
import inputs.Input;
import testobjects.*;

public abstract class SAPInput extends Input {
	public SAPTest parent;
	public ActiveXComponent object, Session;

	public SAPInput(Config config, SAPTest parent) {
		super(config);
		this.parent = parent;
		Session = parent.Session;
	}

	/** Blok testuj�cy widoczno��, klikowalno�� i obecno�� elementu. Wywo�ywa� tylko dla Input�w posiadaj�cych Xpath =/= null */
	public void fill(PList testdata) throws Exception {
		Thread.sleep(Input.waitForInput);
	}
}
