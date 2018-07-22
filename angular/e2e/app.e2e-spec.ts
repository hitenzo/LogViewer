import { LogViewerTemplatePage } from './app.po';

describe('LogViewer App', function() {
  let page: LogViewerTemplatePage;

  beforeEach(() => {
    page = new LogViewerTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
