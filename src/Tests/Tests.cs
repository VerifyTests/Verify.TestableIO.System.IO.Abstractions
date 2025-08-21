[TestFixture]
public class Tests
{
    #region Usage

    [Test]
    public async Task Usage()
    {
        IFileSystem fileSystem = new FileSystem();
        var fileInfo = fileSystem.FileInfo.New(@"C:\temp\temp.txt");
        await Verify(fileInfo);
    }

    #endregion

    [Test]
    public async Task VerifyFileInfo()
    {
        IFileSystem fileSystem = new FileSystem();
        var fileInfo = fileSystem.FileInfo.New(@"C:\temp\temp.txt");
        await Verify(fileInfo);
    }

    [Test]
    public async Task VerifyDirectoryInfo()
    {
        IFileSystem fileSystem = new FileSystem();
        var directoryInfo = fileSystem.DirectoryInfo.New(@"C:\temp");
        await Verify(directoryInfo);
    }
}