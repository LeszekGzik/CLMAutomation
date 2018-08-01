package inputs;

import excel.Config;
import excel.PList;
import testobjects.TestObject;

/** Wykonuje zrzut ekranu. Za nazw� pliku bierze NAME (je�li podane w postaci $NAME) lub pr�buje parse'owa� warto�� parametru Name. */
public class ScreenshotInput extends Input {
	@Override
	public void fill(PList testdata) throws Exception {
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
		
		TestObject.report.scr(data);
	}
	
	public ScreenshotInput(Config config, TestObject parent) {
		super(config, parent);
	}
}
