package excel;


import java.util.HashMap;
import java.util.LinkedHashSet;
import java.util.Set;

/** Mapa parametrów (danych testowych) w postaci (nazwa parametru - wartoœæ) */
public class PList {
	HashMap<String, String> parameters;
	LinkedHashSet<String> keys;
	
	/** dodaje parametr do listy (NIE sprawdza czy ju¿ istnieje!) */
	public void add(String key, String param) {
		parameters.put(key, param);
		keys.add(key);
	}
	
	/** pobiera parametr o nazwie KEY z listy */
	public String get(String key) {
		return parameters.get(key);
	}
	
	public PList() {
		parameters = new HashMap<String, String>();
		keys = new LinkedHashSet<String>();
	}
	
	/** nadaje ju¿ istniej¹cemu parametrowi o nazwie KEY now¹ wartoœæ PARAM */
	public void set(String key, String param) {
		parameters.replace(key, param);
	}
	
	public Set<String> getKeys() {
		return keys;
	}
	
	@Override
	public String toString() {
		String list = "name:\t\tvalue:";
		for (String key : parameters.keySet()) {
			list+="\n" + key + "\t" + parameters.get(key);
		}
		return list;
	}
}
