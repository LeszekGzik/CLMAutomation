package inputs.sap;

import com.jacob.activeX.ActiveXComponent;

import excel.Config;
import excel.PList;
import testobjects.SAPTest;

/** Kilka dwukrotnie w przycisk (lub inny element) pod wskazanym Xpath. Wymaga tylko Xpath. */
public class SAPDoubleClickInput extends SAPInput {

	public SAPDoubleClickInput(Config config, SAPTest parent) {
		super(config, parent);
	}
	
	public void fill(PList testdata) throws Exception {
		super.fill(testdata);
		
		object = new ActiveXComponent(Session.invoke("findById", xpath).toDispatch());
		object.invoke("doubleClick");
	}
}
