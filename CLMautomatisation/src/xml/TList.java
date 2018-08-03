package xml;

import java.util.ArrayList;

/** Lista test case'ów wczytywana z pliku ze scenariuszem.
 * W przeciwieñstwie do PList, nazwy testów (kluczy) MOG¥ siê powtarzaæ.
 * Lista jest indeksowana wedle kolejnoœci dodawania elementów.
 * */
public class TList {
	ArrayList<SingleTest> tests;
	
	/** dodaje parametr do listy */
	public void add(SingleTest test) {
		tests.add(test);
	}
	
	/** Pobiera test o numerze index */
	public String getCase(int index) {
		return tests.get(index).getCase();
	}
	
	/** Pobiera krótk¹ nazwê testu (bez rozszerzenia) o numerze index */
	public String getNameOf(int index) {
		return tests.get(index).getName();
	}
	
	/** Pobiera dane do testu o numerze index */
	public String getData(int index) {
		return tests.get(index).getData();
	}
	
	public TList() {
		tests = new ArrayList<SingleTest>();
	}
	
	/** Zwraca iloœæ testów w liœcie */
	public int size() {
		return tests.size();
	}
}
