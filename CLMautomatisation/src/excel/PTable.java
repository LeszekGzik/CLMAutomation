package excel;

/** Dwuwymiarowa tablica parametrów w postaci (nazwa parametru - wartoœæ) */
public class PTable {
	int rowCount;
	PList[] contents;
	String fileName;
	
	public PTable(String fileName, PList[] array) {
		contents = array;
		this.fileName = fileName;
		rowCount = contents.length;
	}
	
	public PList get(int id) {
		return contents[id];
	}
	
	/** Zwraca liczbê wierszy w tabeli (a.k.a. liczbê zestawów danych) */
	public int getSize() {
		return rowCount;
	}
}
