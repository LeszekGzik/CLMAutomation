package xml;

import java.util.ArrayList;

/** Lista test case'�w wczytywana z pliku ze scenariuszem.
 * W przeciwie�stwie do PList, nazwy test�w (kluczy) MOG� si� powtarza�.
 * Lista jest indeksowana wedle kolejno�ci dodawania element�w.
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
	
	/** Pobiera kr�tk� nazw� testu (bez rozszerzenia) o numerze index */
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
	
	/** Zwraca ilo�� test�w w li�cie */
	public int size() {
		return tests.size();
	}
}
