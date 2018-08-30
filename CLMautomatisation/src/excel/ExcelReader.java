package excel;

import java.io.File;
import java.io.FileInputStream;
import java.util.ArrayList;
import java.util.List;

import org.apache.poi.hssf.usermodel.HSSFRow;
import org.apache.poi.hssf.usermodel.HSSFSheet;
import org.apache.poi.hssf.usermodel.HSSFWorkbook;
import org.apache.poi.ss.usermodel.DataFormatter;

import excel.PList;

public class ExcelReader {
	
	/** Czyta tablic� parametr�w (PTable) ze wszystkich wierszy pliku .xls (zak�adaj�c, �e pierwszy wiersz to nag��wki).
	 * Z ka�dego wiersza pliku (poza pierwszym) tworzona jest nowa lista parametr�w, a nast�pnie wszystkie zamykane s� w tabeli. */
	public static PTable readHorizontal(String filePath) {
		PList [] lists = new PList [0];
		HSSFWorkbook workbook;
		File file = new File(filePath);
		try {
			FileInputStream inputStream = new FileInputStream(file);
			workbook = new HSSFWorkbook(inputStream);
			HSSFSheet sheet = workbook.getSheetAt(0);
			DataFormatter formatter = new DataFormatter();
			int rows = sheet.getPhysicalNumberOfRows();
			Boolean [] nonEmptyRows = new Boolean[rows];
			int nonEmptyRowsCount = 0;
			int counter = 0;
			
			for (int i=0; i<rows; i++) {
				nonEmptyRows[i] = false;
				for(int j=0; j<sheet.getRow(i).getPhysicalNumberOfCells(); j++) {
					if ((sheet.getRow(i)!=null) && (sheet.getRow(i).getCell(j)!=null) && (!sheet.getRow(i).getCell(j).getStringCellValue().equals(""))) {
						nonEmptyRows[i] = true;
						nonEmptyRowsCount++;
						break;
					}
				}
			}
			lists = new PList[nonEmptyRowsCount-1];
			HSSFRow firstRow, currentRow;
			String cell1, cell2;
			PList pList;
			
			firstRow = sheet.getRow(0);
			int cols = firstRow.getPhysicalNumberOfCells();
			for (int i = 1; i < rows; i++) {
				if (nonEmptyRows[i]) {
					pList = new PList();
					currentRow = sheet.getRow(i);
					for (int j = 0; j < cols; j++) {
						if ((firstRow.getCell(j)!=null)) {
							cell1 = formatter.formatCellValue(firstRow.getCell(j));
							cell2 = formatter.formatCellValue(currentRow.getCell(j));
							pList.add(cell1, cell2);
						}
					}
					lists[counter]=pList;
					counter++;
				}
			}
			workbook.close();
			inputStream.close();
		} catch (Exception e) {
			System.out.println(e.getMessage());
		}
		return new PTable(file.getName(), lists);
	}

	/** Czyta instrukcje z pliku config.xls (zak�adany format type - xpath - argument - step)
	 * Czyta od wiersza 2-go (pierwszy to nag��wki)
	 * */
	public static List<Config> readConfig(String filePath) {
		List<Config> list = new ArrayList<Config>();
		HSSFWorkbook workbook;
		try {
			FileInputStream inputStream = new FileInputStream(new File(filePath));
			workbook = new HSSFWorkbook(inputStream);
			HSSFSheet sheet = workbook.getSheetAt(0);
			DataFormatter formatter = new DataFormatter();
			int rows = sheet.getPhysicalNumberOfRows();
			Boolean [] nonEmptyRows = new Boolean[rows];
			for (int i=0; i<rows; i++) {
				nonEmptyRows[i] = false;
				for(int j=0; j<sheet.getRow(i).getPhysicalNumberOfCells(); j++) {
					if ((sheet.getRow(i)!=null) && (sheet.getRow(i).getCell(j)!=null) && (!sheet.getRow(i).getCell(j).getStringCellValue().equals(""))) {
						nonEmptyRows[i] = true;
						break;
					}
				}
			}
			
			String cell1, cell2, cell3, cell4;
			for (int i = 1; i < rows; i++) {
				if (nonEmptyRows[i]) {
					cell1 = formatter.formatCellValue(sheet.getRow(i).getCell(0));
					cell2 = formatter.formatCellValue(sheet.getRow(i).getCell(1));
					cell3 = formatter.formatCellValue(sheet.getRow(i).getCell(2));
					cell4 = formatter.formatCellValue(sheet.getRow(i).getCell(3));
					list.add(new Config(cell1, cell2, cell3, cell4));
				}
			}
			workbook.close();
			inputStream.close();
		} catch (Exception e) {
			System.out.println(e.getMessage());
		}
		return list;
	}

	/** Czyta list� test�w (TList) z pierwszych dw�ch kolumn pliku .xls (zak�adaj�c, �e pierwsza kolumna to nazwy test�w, a druga to dane testowe) 
	public static TList readVertical(String filePath) {
		TList tList = new TList();
		HSSFWorkbook workbook;
		try {
			FileInputStream inputStream = new FileInputStream(new File(filePath));
			workbook = new HSSFWorkbook(inputStream);
			HSSFSheet sheet = workbook.getSheetAt(0);
			DataFormatter formatter = new DataFormatter();
			int rows = sheet.getPhysicalNumberOfRows();
			
			//sprawdzanie kt�re wiersze s� nie-puste
			Boolean [] nonEmptyRows = new Boolean[rows];
			for (int i=0; i<rows; i++) {
				nonEmptyRows[i] = false;
				for(int j=0; j<sheet.getRow(i).getPhysicalNumberOfCells(); j++) {
					if ((sheet.getRow(i)!=null)&&(sheet.getRow(i).getCell(j)!=null) && (!sheet.getRow(i).getCell(j).getStringCellValue().equals(""))) {
						nonEmptyRows[i] = true;
						break;
					}
				}
			}
			
			String cell1, cell2;
			for (int i = 1; i < rows; i++) {
				if (nonEmptyRows[i]) {
					cell1 = formatter.formatCellValue(sheet.getRow(i).getCell(0));
					cell2 = formatter.formatCellValue(sheet.getRow(i).getCell(1));
					tList.add(cell1, cell2);
				}
			}
			workbook.close();
			inputStream.close();
		} catch (Exception e) {
			System.out.println(e.getMessage());
		}
		return tList;
	}*/
}
