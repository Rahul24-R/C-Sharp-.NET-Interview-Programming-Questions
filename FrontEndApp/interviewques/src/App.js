import React, { useState, useEffect } from 'react';
import { Card, CardContent, Button, Typography, CircularProgress, CardHeader, CardActions } from '@mui/material';
import './App.css'; // Import your app.css file
import IconButton, { IconButtonProps } from '@mui/material/IconButton';
import ShareIcon from '@mui/icons-material/Share';

const InterviewQuestionsList = () => {
  const [questions, setQuestions] = useState([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);

  useEffect(() => {
    const fetchData = async () => {
      try {
        const response = await fetch('http://localhost:3000/questions');
        if (!response.ok) {
          throw new Error('Failed to fetch data');
        }
        const data = await response.json();

        if (!Array.isArray(data)) {
          throw new Error('Invalid data structure. Expected an array.');
        }

        setQuestions(data);
      } catch (error) {
        console.error('Error fetching data:', error.message);
        setError('Error fetching data');
      } finally {
        setLoading(false);
      }
    };

    fetchData();
  }, []);

  return (
    <div>
      <header className="App-header">
        <h1>Interview Questions Website</h1>
        <p>Welcome to our platform for practicing interview questions.</p>
      </header>
      <main>
        {loading && <CircularProgress />}
        {error && <Typography color="error">{error}</Typography>}
        {!loading && !error && (
          <div>
            <Typography component="div" variant='h3'>List of Questions</Typography>
            {questions.map((question) => (
              <Card key={question.id} className="question-card" variant="outlined">              
                <CardContent> 
                  <Typography gutterBottom variant="h5" component="div">{question.title}</Typography>                 
                  <Typography>Language Type: {question.languageType}</Typography>
                  <Typography>Category: {question.category}</Typography>
                  <Typography>Difficulty Level: {question.difficulty}</Typography>                  
                </CardContent>
                <CardActions disableSpacing>
                    <IconButton aria-label="share">
                    <ShareIcon />
                  </IconButton>
                </CardActions>
              </Card>
            ))}
          </div>
        )}
      </main>
    </div>
  );
};

const navigateToSolutionsPage = (questionId) => {
  // Implement navigation logic to the solutions page using React Router or your preferred method
  console.log(`Navigate to solutions page for question ${questionId}`);
};

export default InterviewQuestionsList;
