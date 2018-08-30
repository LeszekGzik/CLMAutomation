package inputs;

import excel.Config;
import excel.PList;
import logging.ReportManager;
import testobjects.TestObject;

public class CurrentDateInput extends Input {

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
	
	public CurrentDateInput(Config config, TestObject parent) {
		super(config, parent);
	}

}
