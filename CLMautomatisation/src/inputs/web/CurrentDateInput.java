package inputs.web;

import excel.Config;
import excel.PList;
import inputs.Input;
import logging.ReportManager;
import testobjects.TestObject;
import testobjects.WebTest;

public class CurrentDateInput extends WebInput {

	@Override
	public void fill(PList testdata) throws Exception {
		PList data;
		if (name.charAt(0)=='&') {
			data = TestObject.globaldata;
			name = name.substring(1);
		}
		else {
			data = testdata;
		}
		
		if(data.get(name)!=null) {
			data.set(name, ReportManager.formattedDateTime());
		}
		else {
			data.add(name, ReportManager.formattedDateTime());
		}
	}
	
	public CurrentDateInput(Config config, WebTest parent) {
		super(config, parent);
	}

}
