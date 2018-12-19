package inputs.sap;

import com.jacob.activeX.ActiveXComponent;

import excel.Config;
import excel.PList;
import testobjects.SAPTest;

public class SAPEnterInput extends SAPInput {

	public SAPEnterInput(Config config, SAPTest parent) {
		super(config, parent);
	}
	
	public void fill(PList testdata) throws Exception {
		super.fill(testdata);
		
		object = new ActiveXComponent(Session.invoke("findById", xpath).toDispatch());
		object.invoke("sendVKey", 0);
	}
}
