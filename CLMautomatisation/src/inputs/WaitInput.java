package inputs;

import excel.Config;
import excel.PList;
import testobjects.TestObject;

/** Czeka X milisekund (jeœli Name=$X) lub próbuje parse'owaæ wartoœæ parametru Name. */
public class WaitInput extends Input {
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
	
	public WaitInput(Config config, TestObject parent) {
		super(config, parent);
	}
}
