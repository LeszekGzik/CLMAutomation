package inputs.web;

import excel.Config;
import excel.PList;
import inputs.Input;
import testobjects.TestObject;
import testobjects.WebTest;

/** Czeka X milisekund (je�li Name=$X) lub pr�buje parse'owa� warto�� parametru Name. */
public class WaitInput extends WebInput {
	@Override
	public void fill(PList testdata) throws InterruptedException {
		
		String data;
		if (name.charAt(0)=='&') {
			data = TestObject.globaldata.get(name.substring(1));
		}
		else if (name.charAt(0)=='$') {
			data = name.substring(1);
		}
		else {
			data = testdata.get(name);
		}
		
		Thread.sleep(Integer.parseInt(data));
	}
	
	public WaitInput(Config config, WebTest parent) {
		super(config, parent);
	}
}
