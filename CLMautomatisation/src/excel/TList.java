package excel;

import java.util.ArrayList;

/** Lista test case'�w wczytywana z pliku ze scenariuszem.
 * W przeciwie�stwie do PList, nazwy test�w (kluczy) MOG� si� powtarza�.
 * Lista jest indeksowana wedle kolejno�ci dodawania element�w.
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
	
	/** Pobiera kr�tk� nazw� testu (bez rozszerzenia) o numerze index */
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
	
	/** Zwraca ilo�� test�w w li�cie */
	public int size() {
		return testcases.size();
	}
}
