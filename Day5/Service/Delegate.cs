delegate void DelegateService(int value);

class DelegateProgram
{
    public void DelegateRun(DelegateService service, int value){
        service(value);
    }
}
