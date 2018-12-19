package inputs.sap;

import com.jacob.activeX.ActiveXComponent;

import excel.Config;
import testobjects.SAPTest;
import testobjects.TestObject;
import excel.PList;

public class SAPTextInput extends SAPInput {

	public SAPTextInput(Config config, SAPTest parent) {
		super(config, parent);
	}
	
	public void fill(PList testdata) throws Exception {
		super.fill(testdata);
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
		
		object = new ActiveXComponent(Session.invoke("findById", xpath).toDispatch());
		object.setProperty("text", data);
	}
}
