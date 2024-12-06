void Main(){
    List<double> d = [2, 18, 7.2, 92, 29.2];
    d.RemoveAt(3);

    double a = Medel(d);
    Console.WriteLine(a);

}

double Medel( List<double> doubles){
    double medel = 0;
    foreach ( double element in doubles){
        medel += element;
    }

    medel /= doubles.Count;
    return medel;
}
Main();
