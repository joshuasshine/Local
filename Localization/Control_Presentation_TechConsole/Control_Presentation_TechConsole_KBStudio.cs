using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AetherPal.Control.Presentation.Localization
{
    class Control_Presentation_TechConsole_KBStudio : ILocalize
    {
        public Type Type { get { return this.GetType(); } }
        public ushort Identifier { get { return 0x4201; } }

        public string AWC_KBStudio_SoundRecorder_Start { get { return "START"; } }
        public string AWC_KBStudio_SoundRecorder_Play { get { return "PLAY"; } }
        public string AWC_KBStudio_SoundRecorder_Pause { get { return "PAUSE"; } }
        public string AWC_KBStudio_SoundRecorder_ChooseRecordingDevice { get { return "Choose Recording Device"; } }
        public string AWC_KBStudio_SoundRecorder_Record { get { return "Record"; } }
        public string AWC_KBStudio_SoundRecorder_Duration { get { return "Duration"; } }
        public string AWC_KBStudio_SoundRecorder_Apply { get { return "APPLY"; } }
        public string AWC_KBStudio_SoundRecorder_NoInputDevice { get { return "No input device found"; } }
        public string AWC_KBStudio_SoundRecorder_Recording { get { return "Recording..."; } }

        public string AWC_KBStudio_AddArticle_Title { get { return "Title"; } }
        public string AWC_KBStudio_AddArticle_EditTitle { get { return "Edit Title"; } }        
        public string AWC_KBStudio_AddArticle_EditName { get { return "Edit Name"; } }
        public string AWC_KBStudio_AddArticle_Features { get { return "Features"; } }
        public string AWC_KBStudio_AddArticle_ArticleID { get { return "ArticleID"; } }
      
        public string AWC_KBStudio_AnimationEditor_StopRecording { get { return "STOP RECORDING"; } }
        public string AWC_KBStudio_AnimationEditor_PreviewAll { get { return "PREVIEW ALL"; } }
        public string AWC_KBStudio_AnimationEditor_StopPreview { get { return "STOP PREVIEW"; } }
        public string AWC_KBStudio_AnimationEditor_StartRecording { get { return "START RECORDING"; } }
        public string AWC_KBStudio_AnimationEditor_View { get { return "VIEW"; } }
        public string AWC_KBStudio_AnimationEditor_Preview { get { return "PREVIEW"; } }
        public string AWC_KBStudio_AnimationEditor_Publish { get { return "PUBLISH"; } }
        public string AWC_KBStudio_AnimationEditor_Exit { get { return "EXIT"; } }
        public string AWC_KBStudio_AnimationEditor_Elements { get { return "ELEMENTS"; } }
        public string AWC_KBStudio_AnimationEditor_StartLocation { get { return "Start Location : "; } }
        public string AWC_KBStudio_AnimationEditor_EndLocation { get { return "End Location : "; } }
        public string AWC_KBStudio_AnimationEditor_HideBeforeAnimation { get { return "Hide Before Animation"; } }
        public string AWC_KBStudio_AnimationEditor_HideAfterAnimation { get { return "Hide After Animation"; } }
        public string AWC_KBStudio_AnimationEditor_Steps { get { return "STEPS"; } }
        public string AWC_KBStudio_AnimationEditor_MoveToBottom { get { return "Move to Bottom"; } }
        public string AWC_KBStudio_AnimationEditor_MoveDown { get { return "Move Down"; } }
        public string AWC_KBStudio_AnimationEditor_MoveUp { get { return "Move Up"; } }
        public string AWC_KBStudio_AnimationEditor_MoveToTop { get { return "Move to Top"; } }       
        public string AWC_KBStudio_AnimationEditor_Description { get { return "DESCRIPTION"; } }
        public string AWC_KBStudio_AnimationEditor_LoadImage { get { return "Load Image"; } }        
        public string AWC_KBStudio_AnimationEditor_ItemAlreadyAdded { get { return "Item has been already added."; } }

        public string AWC_KBStudio_ArticleEditor_FitToScreen { get { return "Fit To Screen"; } }
        public string AWC_KBStudio_ArticleEditor_ExitEditor { get { return "Exit Editor"; } }
        public string AWC_KBStudio_ArticleEditor_ExpandAll { get { return "Expand All"; } }
        public string AWC_KBStudio_ArticleEditor_PromptToClose { get { return "Do you wish to close the editor window?"; } }
        public string AWC_KBStudio_ArticleEditor_ArticleInOfflineMsg { get { return "This article is created in Offline mode and does not contain any data file."; } }
        public string AWC_KBStudio_ArticleEditor_GestureAnimationStarted { get { return "Gesture Animation Started"; } }
        public string AWC_KBStudio_ArticleEditor_MultipleBailOutScriptMsg { get { return "Article cannot have more than one bailout script!"; } }
        public string AWC_KBStudio_ArticleEditor_CompilationFaliedMsg { get { return "Script Compilation failed!"; } }
        public string AWC_KBStudio_ArticleEditor_LineForSwipe { get { return "Draw the line to represent swipe direction"; } }
        public string AWC_KBStudio_ArticleEditor_GestureAnimationEnded { get { return "Gesture Animation Ended"; } }
        public string AWC_KBStudio_ArticleEditor_SingleGestureAnimationEnabled { get { return "Single gesture animation enabled"; } }
        public string AWC_KBStudio_ArticleEditor_SaveArticle { get { return "Save Article"; } }
        public string AWC_KBStudio_ArticleEditor_ConfirmDeleteAudio { get { return "Do you wish to delete this audio?"; } }
        public string AWC_KBStudio_ArticleEditor_ConfirmOverideAudio { get { return "Audio is already available for this step. Do you wish to overwrite this audio?"; } }
        public string AWC_KBStudio_ArticleEditor_GestureAnimationWithImage { get { return "Gesture animation with single image."; } }

        public string AWC_KBStudio_ArticleList_AddArticle { get { return "Add Article"; } }
        public string AWC_KBStudio_ArticleList_Edit { get { return "Edit"; } }      
        public string AWC_KBStudio_ArticleList_Property { get { return "Property"; } }
        public string AWC_KBStudio_ArticleList_Commit { get { return "Commit"; } }
        public string AWC_KBStudio_ArticleList_ViewHistory { get { return "View History"; } }
        public string AWC_KBStudio_ArticleList_All { get { return "All"; } }
        public string AWC_KBStudio_ArticleList_Approved { get { return "Approved"; } }
        public string AWC_KBStudio_ArticleList_Rejected { get { return "Rejected"; } }
        public string AWC_KBStudio_ArticleList_Pending { get { return "Pending"; } }
        public string AWC_KBStudio_ArticleList_New { get { return "New"; } }
        public string AWC_KBStudio_ArticleList_Properties { get { return "PROPERTIES"; } }
        public string AWC_KBStudio_ArticleList_ArticleName { get { return "Article Name"; } }
        public string AWC_KBStudio_ArticleList_ArticleTitle { get { return "Article Title"; } }
        public string AWC_KBStudio_ArticleList_Keyword { get { return "Keyword"; } }     
        public string AWC_KBStudio_ArticleList_OEM { get { return "OEM"; } }       
        public string AWC_KBStudio_ArticleList_OSVersion { get { return "OS Version"; } }
        public string AWC_KBStudio_ArticleList_AricleCommitSucessMsg { get { return "Article commit successful"; } }
        public string AWC_KBStudio_ArticleList_AricleCommitFailedMsg { get { return "Article commit failed!"; } }
        public string AWC_KBStudio_ArticleList_ConfirmDeleteArticle { get { return "Do you want to delete \"{0}\" article?"; } }
        public string AWC_KBStudio_ArticleList_ExpandAll { get { return "Expand All"; } }
        public string AWC_KBStudio_ArticleList_CollapseAll { get { return "Collapse All"; } }
        public string AWC_KBStudio_ArticleList_EditProperty { get { return "Edit Property"; } }
        
        public string AWC_KBStudio_CommentDialog_Commit { get { return "COMMIT"; } }
        public string AWC_KBStudio_CommentDialog_CommentToCommit { get { return "Enter your comment to COMMIT the changes."; } }
            
        public string AWC_KBStudio_DecisionFlowEditor_DecisionFlow { get { return "KB Studio - Decision Flow"; } }
        public string AWC_KBStudio_DecisionFlowEditor_Text { get { return "Text"; } }
        public string AWC_KBStudio_DecisionFlowEditor_ID { get { return "ID"; } }
        public string AWC_KBStudio_DecisionFlowEditor_CompareValue { get { return "Compare Value"; } }
        public string AWC_KBStudio_DecisionFlowEditor_TimeOut { get { return "Time Out [In Secs]"; } }   
        public string AWC_KBStudio_DecisionFlowEditor_TextRequired { get { return "Text Required"; } }
        public string AWC_KBStudio_DecisionFlowEditor_IDRequired { get { return "ID Required"; } }
        public string AWC_KBStudio_DecisionFlowEditor_CompareValueRequired { get { return "Compare Value Required"; } }
        public string AWC_KBStudio_DecisionFlowEditor_TrueStepIDRequired { get { return "True Step ID Required"; } }
        public string AWC_KBStudio_DecisionFlowEditor_FalseStepIDRequired { get { return "False Step ID Required"; } }
        public string AWC_KBStudio_DecisionFlowEditor_TimeOutRequired { get { return "Time out Required"; } }

        public string AWC_KBStudio_DeviceDepotToolBar_KBStudio { get { return "KB Studio"; } }
        public string AWC_KBStudio_DeviceDepotToolBar_Default { get { return "Default"; } }
        public string AWC_KBStudio_DeviceDepotToolBar_ChooseShapes { get { return "Choose Shapes"; } }
        public string AWC_KBStudio_DeviceDepotToolBar_Oval { get { return "Oval"; } }
        public string AWC_KBStudio_DeviceDepotToolBar_Rectangle { get { return "Rectangle"; } }
        public string AWC_KBStudio_DeviceDepotToolBar_Text { get { return "Text"; } }
        public string AWC_KBStudio_DeviceDepotToolBar_Gesture { get { return "Gesture"; } }
        public string AWC_KBStudio_DeviceDepotToolBar_DecisionFlow { get { return "Decision Flow"; } }
        public string AWC_KBStudio_DeviceDepotToolBar_Script { get { return "Script"; } }
        public string AWC_KBStudio_DeviceDepotToolBar_None { get { return "None"; } }
        public string AWC_KBStudio_DeviceDepotToolBar_Import { get { return "Import"; } }
        public string AWC_KBStudio_DeviceDepotToolBar_BailOutScript { get { return "BailOutScript"; } }

        public string AWC_KBStudio_LinkArticleDialog_RelatedArticles { get { return "RELATED ARTICLES"; } }
        public string AWC_KBStudio_LinkArticleDialog_NoRelatedArticles { get { return "No Related Articles"; } }

        public string AWC_KBStudio_LoginDialog_Login { get { return "LOGIN"; } }
        public string AWC_KBStudio_LoginDialog_LoginToRetrieve { get { return "Please login to retrieve articles"; } }
        public string AWC_KBStudio_LoginDialog_Error { get { return "Error"; } }
       
        public string AWC_KBStudio_NewArticle_CloseEditorMsg { get { return "Do you wish to close the editor window?"; } }
        public string AWC_KBStudio_NewArticle_MultipleBailOutScriptMsg { get { return "Article cannot have more than one bailout script!"; } }
        public string AWC_KBStudio_NewArticle_ScriptFailedMsg { get { return "Script Compilation failed!"; } }
       
        public string AWC_KBStudio_NewStoryboardForm_StudioNewArticle { get { return "STUDIO - NEW ARTICLE"; } }             
        public string AWC_KBStudio_NewStoryboardForm_Searchdevice { get { return "Search device"; } }
        public string AWC_KBStudio_NewStoryboardForm_LoadingOS { get { return "Loading OS..."; } }
        public string AWC_KBStudio_NewStoryboardForm_SelectOS { get { return "Select atleast one OS"; } }
        public string AWC_KBStudio_NewStoryboardForm_NoOSavailable { get { return "No OS available"; } }
        public string AWC_KBStudio_NewStoryboardForm_SelectOneManufacturer { get { return "Select atleast one Manufacturer"; } }
        public string AWC_KBStudio_NewStoryboardForm_CreateOfflineArticles { get { return "Create Offline Articles"; } }
        public string AWC_KBStudio_NewStoryboardForm_HardwareTitle { get { return "Hardware Title"; } }
        public string AWC_KBStudio_NewStoryboardForm_HardwareName { get { return "Hardware Name"; } }
        public string AWC_KBStudio_NewStoryboardForm_AnimationStudio { get { return "Animation Studio"; } }
        public string AWC_KBStudio_NewStoryboardForm_Required { get { return "Required"; } } 
        public string AWC_KBStudio_NewStoryboardForm_SelectDevice { get { return "Select atleast one device"; } }
        public string AWC_KBStudio_NewStoryboardForm_DeviceNotConnected { get { return "This device cannot be connected"; } }        
        public string AWC_KBStudio_NewStoryboardForm_Manufacturers { get { return "Manufacturers"; } }       
        public string AWC_KBStudio_NewStoryboardForm_Workspace { get { return "Workspace : "; } }
        public string AWC_KBStudio_NewStoryboardForm_Namespace { get { return "Namespace : "; } }

        public string AWC_KBStudio_ScriptEditor_KBScriptEditor { get { return "KB Studio - Script Editor"; } }
        public string AWC_KBStudio_ScriptEditor_Title { get { return "Title : "; } }
        public string AWC_KBStudio_ScriptEditor_StoryBoardTagType { get { return "StoryBoard TagType : "; } }   
        
        public string AWC_KBStudio_StoryboardTagPanel_MoveBottom { get { return "Move to Bottom"; } }
        public string AWC_KBStudio_StoryboardTagPanel_MoveDown { get { return "Move Down"; } }
        public string AWC_KBStudio_StoryboardTagPanel_MoveUp { get { return "Move Up"; } }
        public string AWC_KBStudio_StoryboardTagPanel_MoveTop { get { return "Move to Top"; } }   
        public string AWC_KBStudio_StoryboardTagPanel_LoadAudio { get { return "Load Audio"; } }
        public string AWC_KBStudio_StoryboardTagPanel_ArticleSteps { get { return "Article Steps :"; } }

        public string AWC_KBStudio_StudioExplorer_ArticlesList { get { return "Articles List"; } }
        public string AWC_KBStudio_StudioExplorer_HardwareAnimation { get { return "Hardware Animation"; } }

        public string AWC_KBStudio_TextEditor_KBStudioSteps { get { return "KB STUDIO - Steps"; } }
        public string AWC_KBStudio_TextEditor_NextStepID { get { return "Next Step ID"; } }
        public string AWC_KBStudio_TextEditor_ChooseActivity { get { return "Please choose an activity"; } }
        public string AWC_KBStudio_TextEditor_Select { get { return "Select"; } }

        public string AWC_KBStudio_ViewHistory_Title { get { return "VIEW HISTORY"; } }     
        public string AWC_KBStudio_ViewHistory_Author { get { return "Author"; } }
        public string AWC_KBStudio_ViewHistory_SubmissionDate { get { return "Submission Date"; } }
        public string AWC_KBStudio_ViewHistory_Approver { get { return "Approver"; } }
        public string AWC_KBStudio_ViewHistory_ApprovalDate { get { return "Approval Date"; } }
        public string AWC_KBStudio_ViewHistory_FileRevision { get { return "FileRevision"; } }
        public string AWC_KBStudio_ViewHistory_AuthorComments { get { return "Author Comments"; } }
        public string AWC_KBStudio_ViewHistory_ApproverComments { get { return "Approver Comments"; } }

        public string AWC_KBStudio_SoundRecorderViewModel_Recording { get { return "Recording..."; } }
        public string AWC_KBStudio_SoundRecorderViewModel_ErrorOnPlayBack { get { return "Something went wrong during playback[CaptureOnDataAvailable]."; } }
        public string AWC_KBStudio_SoundRecorderViewModel_RecordingStopped { get { return "Recording Stopped"; } }
        public string AWC_KBStudio_SoundRecorderViewModel_RecordingError { get { return "Recording Error:"; } } 

        public string AWC_KBStudio_MainPage_Studio { get { return "STUDIO"; } }

        public string AWC_KBStudio_RichTextBoxEditor_LinkArticle { get { return "Link Article"; } }
        public string AWC_KBStudio_RichTextBoxEditor_Bold { get { return "Bold"; } }
        public string AWC_KBStudio_RichTextBoxEditor_Italic { get { return "Italic"; } }
        public string AWC_KBStudio_RichTextBoxEditor_Underline { get { return "Underline"; } }
        public string AWC_KBStudio_RichTextBoxEditor_GrowFont { get { return "Grow Font"; } }
        public string AWC_KBStudio_RichTextBoxEditor_ShrinkFont { get { return "Shrink Font"; } }
        public string AWC_KBStudio_RichTextBoxEditor_Bullets { get { return "Bullets"; } }
        public string AWC_KBStudio_RichTextBoxEditor_Numbering { get { return "Numbering"; } }
        public string AWC_KBStudio_RichTextBoxEditor_AlignLeft { get { return "Align Left"; } }
        public string AWC_KBStudio_RichTextBoxEditor_AlignCenter { get { return "Align Center"; } }
        public string AWC_KBStudio_RichTextBoxEditor_AlignRight { get { return "Align Right"; } }
        public string AWC_KBStudio_RichTextBoxEditor_AlignJustify { get { return "Align Justify"; } }
        public string AWC_KBStudio_RichTextBoxEditor_IncreaseIndent { get { return "Increase Indent"; } }
        public string AWC_KBStudio_RichTextBoxEditor_DecreaseIndent { get { return "Decrease Indent"; } }

        public string AWC_KBStudio_RecordingsViewModel_CouldNotDeleteRecording { get { return "Could not delete recording"; } }

        public string AWC_KBStudio_PlayAudioToolTipControl_Import { get { return "Import"; } }
        public string AWC_KBStudio_NewStoryboardForm_ConfirmArticleCreation { get { return "Article creation is already in progress. Do you wish to overwrite it ?"; } }
        public string AWC_KBStudio_ArticleList_ConfirmMoveArticle { get { return "Would you like to move this Article ({0}) into Namespace ({1}) ?"; } }
        public string AWC_KBStudio_ArticleList_FailedArticleMoving { get { return "Failed to copy/move the article"; } }

        public string AWC_KBStudio_NewStoryboardForm_IncludeSkin { get { return "Include Skin"; } }
        public string AWC_KBStudio_ArticleList_ClearAllArticle { get { return "Clear all article(s)"; } }
        public string AWC_KBStudio_ArticleList_CopytoLsit { get { return "Copy to list"; } }
        public string AWC_KBStudio_ArticleList_PasteFromList { get { return "Paste from list"; } }
        public string AWC_KBStudio_ArticleList_MoreThan5DevicesErrorMsg { get { return "Only {0} articles can be added to collection for copying articles between namespace"; } }
        public string AWC_KBStudio_ArticleList_CopyArticleListInfoMsg { get { return "Copying article(s) {0}/{1} to Namespace ({2})"; } }
        public string AWC_KBStudio_ArticleList_ArticleExistErrorMsg { get { return "This article ({0}) is already exist in list"; } }
        public string AWC_KBStudio_ArticleList_MoveTo { get { return "Move To"; } }

        public string AWC_KBStudio_TextEditor_SelectionErrorMsg { get { return "Text selection should fall under within a paragraph."; } }
        public string AWC_KBStudio_LinkArticle_Internal { get { return "Internal Article Link ({0})"; } }
        public string AWC_KBStudio_LinkArticle_External { get { return "External Article Link"; } }
        public string AWC_KBStudio_LinkArticle_SearchArticle { get { return "Search Article"; } }
    }
}
