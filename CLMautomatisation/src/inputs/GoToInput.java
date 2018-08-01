package inputs;

import excel.Config;
import excel.PList;
import testobjects.TestObject;

/** Przechodzi pod wskazany URL. Wymaga tylko Name. */
public class GoToInput extends Input {
	
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
		driver.navigate().to(data);
	}
	
	public GoToInput(Config config, TestObject parent) {
		super(config, parent);
	}
}
