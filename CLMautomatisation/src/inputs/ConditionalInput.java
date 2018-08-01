package inputs;

import excel.Config;
import excel.PList;
import testobjects.TestObject;

/** Ustawia flagê continueStep na false, jeœli zadany parametr jest pusty w testdata. Krok wtedy zostanie zatrzymany. */
public class ConditionalInput extends Input {
	@Override
	public void fill(PList testdata) throws InterruptedException {
		
		PList data;
		if (name.charAt(0)=='&') {
			data = TestObject.globaldata;
			name = name.substring(1);
		}
		else {
			data = testdata;
		}
		
		if (data.get(name)==null) {
			continueStep = false;
		}
		else if (data.get(name).equals("")) {
			continueStep = false;
		}
	}
	
	public ConditionalInput(Config config, TestObject parent) {
		super(config, parent);
	}
}
