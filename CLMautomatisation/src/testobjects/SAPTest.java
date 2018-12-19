package testobjects;

import java.util.List;
import java.util.Properties;

import com.jacob.activeX.ActiveXComponent;
import com.jacob.com.ComThread;
import com.jacob.com.Dispatch;
import com.jacob.com.Variant;

import excel.Config;
import excel.PList;
import inputs.Input;
import inputs.sap.*;
import logging.ReportManager;

public class SAPTest extends TestObject {
	public ActiveXComponent SAPROTWr, GUIApp, Connection, Session, Obj;
    public Dispatch ROTEntry;
    public Variant Value, ScriptEngine;
    public Variant[] arg;
	
	public SAPTest(String name, String parentName, List<Config> config, PList testdata, Properties properties) {
		super(name, parentName, config, testdata, properties);
		ComThread.InitSTA();

		SAPROTWr = new ActiveXComponent("SapROTWr.SapROTWrapper");
        ROTEntry = SAPROTWr.invoke("GetROTEntry", "SAPGUI").toDispatch();
        ScriptEngine = Dispatch.call(ROTEntry, "GetScriptingEngine");
        GUIApp = new ActiveXComponent(ScriptEngine.toDispatch());
        Connection = new ActiveXComponent(GUIApp.invoke("Children", 0).toDispatch());
        Session = new ActiveXComponent(Connection.invoke("Children", 0).toDispatch());
        
        for (Config c : config) {
			Input input;
			switch(c.getType()) {
				case "T":
					input = new SAPTextInput(c, this);
					inputs.add(input);
					break;
				case "ENTER":
					input = new SAPEnterInput(c, this);
					inputs.add(input);
					break;
			}
		}
		getSteps();
		report = new ReportManager(properties);
	}

}
