package inputs;

import excel.Config;
import excel.PList;
import testobjects.TestObject;

/** Identyczne do ConditionalInput, ale zatrzymuje ca³y test, nie tylko krok */
public class ConditionalTestInput extends Input {
	
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
			parent.continueTest = false;
		}
		else if (data.get(name).equals("")) {
			continueStep = false;
			parent.continueTest = false;
		}
	}
	
	public ConditionalTestInput(Config config, TestObject parent) {
		super(config, parent);
		// TODO Auto-generated constructor stub
	}

}
