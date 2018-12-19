package inputs.web;

import excel.Config;
import excel.PList;
import inputs.Input;
import testobjects.TestObject;
import testobjects.WebTest;

/** Wykonuje zrzut ekranu. Za nazwê pliku bierze NAME (jeœli podane w postaci $NAME) lub próbuje parse'owaæ wartoœæ parametru Name. */
public class ScreenshotInput extends WebInput {
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
	
	public ScreenshotInput(Config config, WebTest parent) {
		super(config, parent);
	}
}
