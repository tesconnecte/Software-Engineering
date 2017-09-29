
public class Test {
	public static void main(String[] args) {
		Undergraduate undergraduateStudent = new Undergraduate();
		
		undergraduateStudent.setMatric(40326917);
		undergraduateStudent.setName("Sarah Clinton");
		undergraduateStudent.setProgramme("BEng Software Engineering");
		
		undergraduateStudent.setYear("3rd");
		undergraduateStudent.setCourseDuration(4);
		
		System.out.println(undergraduateStudent.toString());
	
	}

}
