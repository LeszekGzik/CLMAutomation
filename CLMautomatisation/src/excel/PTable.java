package excel;

/** Dwuwymiarowa tablica parametr�w w postaci (nazwa parametru - warto��) */
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
	
	/** Zwraca liczb� wierszy w tabeli (a.k.a. liczb� zestaw�w danych) */
	public int getSize() {
		return rowCount;
	}
}
