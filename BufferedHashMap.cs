class BufferedHashmap : HashMap<Point> {

    private int bufferWidth;
    public int BufferWidth => bufferWidth;
    private List<List<point>> bufferTop = new();
    private List<List<point>> bufferLeft = new();
    private List<List<point>> bufferRight = new();
    private List<List<point>> bufferBottom = new();



    public BufferedHashmap(int HashWidth, int HashHeight, int HashBufferWidth = 1) : base(HashWidth, HashHeight) {
        bufferWidth = HashBufferWidth;
        for (int i = 0; i < bufferWidth; i++) {
            bufferTop.Add(new List<point>());
            bufferLeft.Add(new List<point>());
            bufferRight.Add(new List<point>());
            bufferBottom.Add(new List<point>());

            for (int k = 0; k < width + bufferWidth * 2; k++) {
                bufferTop.Add(new Point());
                bufferBottom.Add(new Point());
            }

            for (int k = 0; k < height; k++) {
                bufferLeft.Add(new Point());
                bufferRight.Add(new Point());
            }
        }
    }


    public List<List<point>> GetBufferArea(float x, float y) {
        List<List<Point>> BufferArea = new();
        
        if (x > BufferWidth) {
            if (x < Width - bufferWidth) {
                if (y > bufferWidth) {
                    if (y < height - bufferWidth) { // No Buffer Intersection

                        
                        for (int i = Math.Floor(x) - bufferWidth; i < Math.Ceiling(x) + bufferWidth; i++) {
                            BufferArea.Add(new List<Point>());

                            for (int k = Math.Floor(y) - bufferWidth; k < Math.Ceiling(y) + bufferWidth; i++) {
                                BufferArea.Add(hashMap[i][y]);
                            }
                        }
                    }
                    else { // Bottom Buffer Intersection

                        
                        for (int i = Math.Floor(x) - bufferWidth; i < Math.Ceiling(x) + bufferWidth; i++) {
                            BufferArea.Add(new List<Point>());

                            for (int k = Math.Floor(y) - bufferWidth; k < height; i++) {
                                BufferArea.Add(hashMap[i][k]);
                            }

                            for (int k = 0; k < bufferWidth - (Height - Math.Floor(y)); k++) {
                                BufferArea.Add(bufferBottom[i + bufferWidth][k]);
                            }
                        }
                    }
                }
                else {
                    if (y < height - bufferWidth) { // Top Buffer Intersection

                        
                        for (int i = Math.Floor(x) - bufferWidth; i < Math.Ceiling(x) + bufferWidth; i++) {
                            BufferArea.Add(new List<Point>());

                            for (int k = 0; k < bufferWidth ; k++) {
                                BufferArea.Add(bufferTop[i + bufferWidth][k]);
                            }

                            for (int k = Math.Floor(y) - bufferWidth; k < height; i++) {
                                BufferArea.Add(hashMap[i][k]);
                            }
                        }
                    }
                    else {// Tob and Bottom Buffer Intersection
                        
                    }
                }
            }
            else { // all with right buffer intersection:
                

                if (y > bufferWidth) { // without right and top intersection
                    

                    if (y < height - bufferWidth) { // right only buffer intersection
                        
                    }
                    else { // right and bottom buffer intersection
                        
                    }
                }
                else {
                    if (y < height - bufferWidth) { // right and top buffer interface
                        
                    }
                    else { // right, top, and bottom buffer interface
                        
                    }
                }
            }
        }
        else { // all left buffer intersection
            
        }
    }

}