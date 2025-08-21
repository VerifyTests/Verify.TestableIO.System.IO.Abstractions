class FileSystemInfoConverter :
    WriteOnlyJsonConverter<IFileSystemInfo>
{
    public override void Write(VerifyJsonWriter writer, IFileSystemInfo value) =>
        writer.Serialize(value.FullName);
}