using CoreNFC;

namespace ensemble {

  // code mainly from https://docs.microsoft.com/en-us/xamarin/ios/platform/introduction-to-ios11/corenfc
  // to start reader session put this in code
  /*
  * Session = new NFCNdefReaderSession(this, null, true);
  * Session?.BeginSession();
  */
  
  // to cancel reader session put this in
  /*
  * Session.InvalidateSession();
  */
  
  interface NFCReaderSession {
  
    public void DidDetect(NFCNdefReaderSession session, NFCNdefMessage[] messages) {
      
      foreach (NFCNdefMessage msg in messages) {  // adds the messages to a list view
        DetectedMessages.Add(msg);
      }
      
      DispatchQueue.MainQueue.DispatchAsync(() => { this.TableView.ReloadData(); });
    }
    
    public void DidInvalidate(NFCNdefReaderSession session, NSError error) {
      
      var readerError = (NFCReaderError)(long)error.Code;
      if (readerError != NFCReaderError.ReaderSessionInvalidationErrorFirstNDEFTagRead &&
        readerError != NFCReaderError.ReaderSessionInvalidationErrorUserCanceled) {
        // how do we want to handle errors???
      }
    }
  }
}
