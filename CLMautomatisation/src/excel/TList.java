package excel;

import java.util.ArrayList;

/** Lista test case'ów wczytywana z pliku ze scenariuszem.
 * W przeciwieñstwie do PList, nazwy testów (kluczy) MOG¥ siê powtarzaæ.
 * Lista jest indeksowana wedle kolejnoœci dodawania elementów.
 * */
public class TList {
	ArrayList<String> testcases;
	ArrayList<String> testdata; 
	
	/** dodaje parametr do listy */
	public void add(String test, String data) {
		testcases.add(test);
		testdata.add(data);
	}
	
	/** Pobiera test o numerze index */
	public String getTest(int index) {
		return testcases.get(index);
	}
	
	/** Pobiera krótk¹ nazwê testu (bez rozszerzenia) o numerze index */
	public String getTestShortName(int index) {
		return testcases.get(index).substring(0, testcases.get(index).lastIndexOf('.'));
	}
	
	/** Pobiera dane do testu o numerze index */
	public String getData(int index) {
		return testdata.get(index);
	}
	
	public TList() {
		testcases = new ArrayList<String>();
		testdata = new ArrayList<String>();
	}
	
	/** Zwraca iloœæ testów w liœcie */
	public int size() {
		return testcases.size();
	}
}
