using System.Security.Cryptography;

namespace Zoo;

public class Clinic
{
    /// <returns>Always true at this stage. TBA actual health check</returns>
    public bool IsHealthy(Animal animal)
    {
        return true; // Health check not implemented yet
    }
}