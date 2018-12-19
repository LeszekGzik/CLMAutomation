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

	/** Blok testuj¹cy widocznoœæ, klikowalnoœæ i obecnoœæ elementu. Wywo³ywaæ tylko dla Inputów posiadaj¹cych Xpath =/= null */
	public void fill(PList testdata) throws Exception {
		Thread.sleep(Input.waitForInput);
	}
}
