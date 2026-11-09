//Exercise 1.2: find the two problems. A colleague wrote this. Name what is wrong with each method, and rewrite them properly.
//void A() { try { Save(); } catch (Exception) { } }
//issue is:
//The catch block is empty, so if Save() fails, the error silently disappears.
//This is called swallowing an exception.
public void A()
{
    try
    {
        Save();
    }
    catch (IOException ex)
    {
        Console.WriteLine($"Save failed: {ex.Message}");
        throw;   
    }
}

//void B() { try { Save(); } catch (Exception ex) { throw ex; } }

void B()
{
    try
    {
        Save();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error while saving: {ex.Message}");
        throw;   
    }
}