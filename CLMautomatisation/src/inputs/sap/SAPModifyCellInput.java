package inputs.sap;

import com.jacob.activeX.ActiveXComponent;
import com.jacob.com.Variant;

import excel.Config;
import excel.PList;
import testobjects.SAPTest;
import testobjects.TestObject;

public class SAPModifyCellInput extends SAPInput {

	public SAPModifyCellInput(Config config, SAPTest parent) {
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
		
		//wydzielanie argumentów (rozdzielonych œrednikami)
		Variant arg[] = new Variant[3];
		arg[0] = new Variant(Integer.parseInt(data.substring(0,data.indexOf(';'))));	//numer wiersza
		data = data.substring(data.indexOf(';')+1);
		arg[1] = new Variant(data.substring(0,data.indexOf(';')));	//nazwa kolumny
		arg[2] = new Variant(data.substring(data.indexOf(';')+1));	//wartoœæ do wpisania do komórki
		
		object = new ActiveXComponent(Session.invoke("findById", xpath).toDispatch());
		object.invoke("modifyCell", arg);
	}
}
