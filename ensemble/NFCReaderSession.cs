namespace ensemble {

  // code mainly from https://docs.microsoft.com/en-us/xamarin/ios/platform/introduction-to-ios11/corenfc
  
  interface NFCReaderSession {
  
    public void DidDetect(NFCReaderSession session, NFCMessage[] messages) {
      
      foreach (NFCMessage msg in messages) {  // adds the messages to a list view
        DetectedMessages.Add(msg);
      }
      
      DispatchQueue.MainQueue.DispatchAsync(() => { this.TableView.ReloadData(); });
    }
    
    public void DidInvalidate(NFCReaderSession session, NSError error) {
      
      var readerError = (NFCReaderError)(long)error.Code;
      if (readerError != NFCReaderError.ReaderSessionInvalidationErrorFirstNDEFTagRead &&
        readerError != NFCReaderError.ReaderSessionInvalidationErrorUserCanceled) {
        // how do we want to handle errors???
      }
    }
  }
}
