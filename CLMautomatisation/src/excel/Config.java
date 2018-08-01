package excel;

import java.util.ArrayList;
import java.util.List;

/** Klasa zawieraj¹ca dane jednej instrukcji (jednego wiersza) pobranej z pliku config.xls  */
public class Config {
	List<String> parameters;
	
	public Config(String type, String xpath, String name, String step) {
		parameters = new ArrayList<String>();
		parameters.add(name);
		parameters.add(type);
		parameters.add(xpath);
		parameters.add(step);
	}
	
	public String getName() {
		return parameters.get(0);
	}
	
	public String getType() {
		return parameters.get(1);
	}
	
	public String getXpath() {
		return parameters.get(2);
	}
	
	public String getStep() {
		return parameters.get(3);
	}
}
