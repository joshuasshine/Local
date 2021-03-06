using AetherPal.Control.Presentation.Localization;
using System;

namespace AetherPal.Control.Presentation.Localization.English
{
    public class Control_Presentation_TechConsole_FileManager : ILocalize
    {
        public Type Type { get { return this.GetType(); } }
        public ushort Identifier { get { return 0x4201; } }
        public string AWC_FileManager_ChooseFolder_Copy { get { return "Please choose a folder or a non-drive root path to copy the file"; } }
        public string AWC_FileManager_ConnectionInterrupted { get { return "Connection interrupted before tool service cretaed!"; } }
        public string AWC_FileManager_Copying { get { return "Copying"; } }
        public string AWC_FileManager_CopyItem { get { return "Copy Item"; } }
        public string AWC_FileManager_CreatedName { get { return "Enter the name to be created :"; } }
        public string AWC_FileManager_CreatingFolderOperationFailed { get { return "Creating folder operation failed."; } }
        public string AWC_FileManager_DeleteConfirm_Exist { get { return "A file with the name '{0}' already exist. Do you want to replace it?"; } }
        public string AWC_FileManager_DeleteConfirm_File { get { return "Are you sure you want to delete '{0}' file?"; } }
        public string AWC_FileManager_DeleteConfirm_Folder { get { return "Are you sure you want to delete '{0}' folder?"; } }
        public string AWC_FileManager_DeletingFileOperationFailed { get { return "Deleting file operation failed."; } }
        public string AWC_FileManager_DeletingFolderOperationFailed { get { return "Deleting folder operation failed."; } }
        public string AWC_FileManager_DeviceStorageOutOfMemory { get { return "Device storage out of memory"; } }
        public string AWC_FileManager_File_Rename { get { return "Enter the file name to be renamed :"; } }
        public string AWC_FileManager_FileAlreadyExists { get { return "File already exists"; } }
        public string AWC_FileManager_FileManagement { get { return "File Management"; } }
        public string AWC_FileManager_FileNotFound { get { return "File not found"; } }
        public string AWC_FileManager_FileOperationCompleted { get { return "File operation completed successfully"; } }
        public string AWC_FileManager_FileOperationFailed { get { return "File operation failed"; } }
        public string AWC_FileManager_FilePermissionDenied { get { return "Permission denied for the file."; } }
        public string AWC_FileManager_FileTransactionLog { get { return "File Transaction Log"; } }
        public string AWC_FileManager_FileTransactionLog_DestinationName { get { return "Destination Name"; } }
        public string AWC_FileManager_FileTransactionLog_Duration { get { return "Duration"; } }
        public string AWC_FileManager_FileTransactionLog_Receive_ErrorMessage { get { return "A file with name '{0}' already exist.Do you want to replace it?"; } }
        public string AWC_FileManager_FileTransactionLog_SourceName { get { return "Source Name"; } }
        public string AWC_FileManager_FileTransferOperationFailed { get { return "File transfer operation failed due to technical error, please retry again."; } }
        public string AWC_FileManager_Folder_Create { get { return "Enter the folder name to be created :"; } }
        public string AWC_FileManager_Folder_Rename { get { return "Enter the folder name to be renamed :"; } }
        public string AWC_FileManager_FolderAlreadyExists { get { return "Folder already exists"; } }
        public string AWC_FileManager_FolderNotFound { get { return "Folder not found"; } }
        public string AWC_FileManager_FolderOperationCompleted { get { return "Folder operation completed successfully"; } }
        public string AWC_FileManager_FolderOperationFailed { get { return "Folder operation failed"; } }
        public string AWC_FileManager_FolderPermissionDenied { get { return "Permission denied for the folder."; } }
        public string AWC_FileManager_FolderTransferOperationFailed { get { return "Folder transfer operation failed due to technical error, please retry again."; } }
        public string AWC_FileManager_Heading { get { return "File Manager"; } }
        public string AWC_FileManager_Inputbox { get { return "Inputbox"; } }
        public string AWC_FileManager_ProcessCanceled { get { return "Process Cancelled"; } }
        public string AWC_FileManager_ProcessCompleted { get { return "Process Completed"; } }
        public string AWC_FileManager_Progress_ClosingConnection { get { return "Closing device connection. Please wait..."; } }
        public string AWC_FileManager_Progress_DeviceInterrupted { get { return "Device connection interrupted. Please wait..."; } }
        public string AWC_FileManager_RemoteDevice { get { return "Remote Device"; } }
        public string AWC_FileManager_RemoteFileCreated { get { return "Remote file '{0}' created"; } }
        public string AWC_FileManager_RemoteFileDeleted { get { return "Remote file deleted."; } }
        public string AWC_FileManager_RemoteFileDeletionFailed { get { return "Remote file '{0}' deletion failed."; } }
        public string AWC_FileManager_RemoteFileOrFolderRenamed { get { return "Remote file/folder '{0}' renamed with '{1}'."; } }
        public string AWC_FileManager_RemoteFileOrFolderRenamedFailed { get { return "Remote file/folder '{0}' renamed with '{1}' failed."; } }
        public string AWC_FileManager_RemoteFilesListed { get { return "Remote files listed under path"; } }
        public string AWC_FileManager_RemoteFolderCreated { get { return "Remote folder '{0}' created"; } }
        public string AWC_FileManager_RemoteFolderDeleted { get { return "Remote folder deleted."; } }
        public string AWC_FileManager_RemoteFolderDeletionFailed { get { return "Remote folder '{0}' deletion failed."; } }
        public string AWC_FileManager_RemoteHomePathRetrived { get { return "Remote home path retrived."; } }
        public string AWC_FileManager_RenameFileOperationFailed { get { return "Rename file operation failed."; } }
        public string AWC_FileManager_RenameFolderOperationFailed { get { return "Rename folder operation failed."; } }
        public string AWC_FileManager_RetrieveDrive_Failure { get { return ""; } }       
        public string AWC_FileManager_Status_FileTransfer_Local { get { return "File Transfer Log [Local device]"; } }
        public string AWC_FileManager_Status_FileTransfer_Remote { get { return "File Transfer Log [Remote device]"; } }
        public string AWC_FileManager_TargetLocation { get { return "Select the location (Path), where you want to move the file. Then Click the 'Copy' button."; } }
        public string AWC_FileManager_UnableToConnectFileManager { get { return "Unable to connect to FileManager service on the device."; } }
        public string AWC_FileManager_UnableToListRemoteFiles { get { return "Unable to list remote files under path"; } }
        public string AWC_FileManager_UnableToRetriveRemoteHomePath { get { return "Unable to retrive remote home path."; } }
        public string AWC_FileManager_Workstation { get { return "Workstation"; } }
        public string AWC_FileManager_Source { get { return "Source"; } }
        public string AWC_FileManager_Destination { get { return "Destination"; } }
    }
}
